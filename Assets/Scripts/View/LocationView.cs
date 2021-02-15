using UnityEngine;


namespace Snake
{
    internal class LocationView : MonoBehaviour
    {
        private ILocationVeiwModel _locationVeiwModel;
        public void Initialize(ILocationVeiwModel locationVeiwModel)
        {
            _locationVeiwModel = locationVeiwModel;
            _locationVeiwModel.OnLocationChange += OnLocationChange;
        }

        private void OnLocationChange(ILocationChangeModel locationChangeModel)
        {
            transform.position = new Vector3(locationChangeModel.CurrentX, locationChangeModel.CurrentY, 0);
        }

        ~LocationView()
        {
            _locationVeiwModel.OnLocationChange -= OnLocationChange;
        }

    }
}
