﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SLCGame.Tools;
using SLCGame.Tools.Unity;

namespace SLCGame.Unity
{
    public class ResourceMgr : Singleton<ResourceMgr>
    {

        public class ResCache
        {
            public float mTimerStay = 0f;
            public float mStayMax = 30f;
            private Object mRes;
            public bool m_isRelease = true;//是否释放
            public Object resCache{
                set{
                    mRes = value;
                }
                get{
                    mTimerStay = 0f;
                    return mRes;
                }
            }
            public void Release()
            {
                if (m_isRelease)
                    Resources.UnloadAsset(mRes);
            }

            public bool Tick()
            {
                mTimerStay += Time.deltaTime;
                return mTimerStay < mStayMax;
            }
        }
        Dictionary<string, ResCache> mCacheDic = new Dictionary<string, ResCache>();

        /// <summary>
        /// 根据情况有的标记为不卸载的可以不卸载
        /// </summary>
        public void ClearResources()
        {
            string[] keys = mCacheDic.Keys.ToArray();
            for (int i = 0; i < keys.Length; ++i)
            {
                mCacheDic[keys[i]].Release();
                if (mCacheDic[keys[i]].m_isRelease)
                    mCacheDic.Remove(keys[i]);
            }
            Resources.UnloadUnusedAssets();
        }
        /// <summary>
        /// 清除全部资源
        /// </summary>
        public void ClearAllResources()
        {
            string[] keys = mCacheDic.Keys.ToArray();
            for (int i = 0; i < keys.Length; ++i)
            {
                mCacheDic[keys[i]].Release();
                if (mCacheDic[keys[i]].m_isRelease)
                    mCacheDic.Remove(keys[i]);
            }
            Resources.UnloadUnusedAssets();
        }

        /// <summary>
        /// 加载Resources对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T New<T>(string path) where T : Object
        {
            if (!Instance.mCacheDic.ContainsKey(path))
            {
                T res = Resources.Load<T>(path);
                if (res == null)
                {
                    DebugMod.LogError("can't find res from " + path);
                    return null;
                }
                Instance.mCacheDic[path] = new ResCache() { resCache = (Object)res };
            }

            T t = U3DMod.Clone<T>(Instance.mCacheDic[path].resCache);
            return t;
        }

        /// <summary>
        /// 加载Resources对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static GameObject New(string path)
        {
            return New<GameObject>(path);
        }

        public static T Load<T>(string path) where T:Object
        {
            if (!Instance.mCacheDic.ContainsKey(path))
            {
                T res = Resources.Load<T>(path);
                if (res == null)
                {
                    DebugMod.LogError("can't find res from " + path);
                    return null;
                }
                Instance.mCacheDic[path] = new ResCache() { resCache = (Object)res };
            }

            return Instance.mCacheDic[path].resCache as T;
        }

        public void Update()
        {
            string[] keys = mCacheDic.Keys.ToArray();
            for (int i = 0; i < keys.Length; ++i) 
            {
                if (!mCacheDic[keys[i]].Tick())
                {
                    mCacheDic.Remove(keys[i]);
                }
            }
        }
    }
}