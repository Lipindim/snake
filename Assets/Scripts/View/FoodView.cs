using UnityEngine;


namespace Snake
{
    internal class FoodView : MonoBehaviour
    {
        private IRandomLocationViewModel _randomLocationViewModel;
        public void Initialize(IRandomLocationViewModel randomLocationViewModel)
        {
            _randomLocationViewModel = randomLocationViewModel;
            _randomLocationViewModel.OnLocationChange += OnLocationChange;
        }

        private void OnLocationChange(ILocationChangeModel locationChangeModel)
        {
            transform.position = new Vector3(locationChangeModel.CurrentX, locationChangeModel.CurrentY, 0);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Столкновение");
            _randomLocationViewModel.ChangeLocation();
        }

            ~FoodView()
        {
            _randomLocationViewModel.OnLocationChange -= OnLocationChange;
        }
    }
}
