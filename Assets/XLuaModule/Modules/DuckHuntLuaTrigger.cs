using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LQQ
{
    public delegate Collider LuaColliderDelegate(Collider _col);
    /// <summary>
    /// 3D Trigger Event
    /// </summary>
    public class DuckHuntLuaTrigger : MonoBehaviour
    {
        public event LuaColliderDelegate EventEnter;
        public event LuaColliderDelegate EventStay;
        public event LuaColliderDelegate EventExit;
        private void OnTriggerEnter(Collider other)
        {
            EventEnter(other);
        }

        private void OnTriggerStay(Collider other)
        {
            EventStay(other);
        }

        private void OnTriggerExit(Collider other)
        {
            EventExit(other);
        }
    }
}
