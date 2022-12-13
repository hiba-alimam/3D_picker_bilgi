using Managers;
using UnityEngine;

namespace Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private PlayerManager manager;
        [SerializeField] private new Collider collider;
        [SerializeField] private new Rigidbody rigidbody;

        #endregion

        #endregion

        private void OntriggerEnter(Collider other)
        {
            if(other.CompareTag("StageArea"))
            {

            }
        }

        public void OnReset()
        {
        }
    }
}
