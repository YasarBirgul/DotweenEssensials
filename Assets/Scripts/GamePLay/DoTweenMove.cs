using UnityEngine;
using DG.Tweening;

namespace GamePlay
{
    public class DoTweenMove : MonoBehaviour
    {
        private Vector3 zero;
        public Vector3 turn;
        private void Start()
        {
            DOTween.Init();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.DOMove(new Vector3(-10,0,0), 5);
            }
            
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.DOMove(new Vector3(+10,0,0), 5);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                zero = new Vector3(0, 0, 10);
                transform.DOJump(zero, 10,1,5);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                transform.DORotate(turn, 3,RotateMode.WorldAxisAdd);
            }
        }
    }
}

