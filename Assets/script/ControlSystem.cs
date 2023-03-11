using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sw
{
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("�ؼЪ���")]
        private Transform target;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            LookatTarget();
        }

        /// <summary>
        /// ���ۥؼ�
        /// </summary>
        private void LookatTarget()
        {
            transform.LookAt(target);//�ܧΤ���.���V(�ؼЪ���)
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);//x z�b�k0
        }
    }
}

