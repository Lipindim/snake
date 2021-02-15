using System.Collections.Generic;
using UnityEngine;


namespace Snake
{
    internal class NewStarter : MonoBehaviour
    {
        [SerializeField] private LocationView _headVeiw;
        [SerializeField] private FoodView _foodView;
        [SerializeField] private GameObject _segmentGameObject;

        private IList<IUpdate> _updates = new List<IUpdate>();

        private void Start()
        {
            var locationModel = new LocationModel(0.5f, 0.5f);
            var roundUpdateViewModel = new RoundUpdateViewModel(0.25f);
            var commandViewModel = new CommandViewModel(roundUpdateViewModel);
            var randomLocationModel = new LocationModel(3.5f, 3.5f);
            var locationCoordinate = new LocationCoordinates(-26, 26, -14, 14);
            var foodLocationViewModel = new RandomLocationViewModel(randomLocationModel, locationCoordinate);
            _updates.Add(commandViewModel);
            _updates.Add(roundUpdateViewModel);
            var headLocationViewModel = new LocationCommandVeiwModel(locationModel, commandViewModel);
            var segmentBuilderViewModel = new SegmentBuilderVeiwModel(_segmentGameObject);
            var segmentContainerModel = new ContainerLocationModel();
            segmentContainerModel.AddLocationViewModel(headLocationViewModel);
            var snakeBuilderViewModel = new SnakeBuilderViewModel(segmentBuilderViewModel, foodLocationViewModel, segmentContainerModel);
            var snakeMoveViewModel = new SnakeMoveViewModel(segmentContainerModel, headLocationViewModel);
            _headVeiw.Initialize(headLocationViewModel);
            _foodView.Initialize(foodLocationViewModel);
        }

        private void Update()
        {
            foreach (IUpdate update in _updates)
            {
                update.Update(Time.deltaTime);
            }
        }
    }
}
