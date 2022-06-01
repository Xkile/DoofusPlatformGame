using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Public Members
   public Transform Doofus;
   public float smoothSpeed = 0.125f;
   public Vector3 offset;
   #endregion

#region Monobehaviour
    private void LateUpdate() {
        Vector3 desiredPosition = Doofus.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
    #endregion

}
