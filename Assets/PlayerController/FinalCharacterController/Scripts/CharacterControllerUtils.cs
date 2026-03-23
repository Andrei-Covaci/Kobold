using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.TextCore.Text;

namespace Kobold.FinalCharacterController
{
    public static class CharacterControllerUtils  
    {
        public static Vector3 GetNormalWithSphereCast(CharacterController characterController, LayerMask layerMask = default)
        {
            Vector3 norlmal = Vector3.up;
            Vector3 origin = characterController.transform.position + characterController.center;
            float distance = characterController.height / 2f + characterController.stepOffset + 0.1f; // Add a small buffer to ensure we detect the ground

            RaycastHit hit;
            if (Physics.SphereCast(origin, characterController.radius, Vector3.down, out hit, distance, layerMask))
            {
                norlmal = hit.normal;
            }
            return norlmal;
        }
    }
}