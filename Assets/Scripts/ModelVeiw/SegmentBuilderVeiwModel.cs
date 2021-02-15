using UnityEngine;


namespace Snake
{
    internal class SegmentBuilderVeiwModel : ISegmentBuilderViewModel
    {
        private readonly GameObject _segmentPrefab;

        public SegmentBuilderVeiwModel(GameObject segmentPrefab)
        {
            _segmentPrefab = segmentPrefab;
        }

        public ILocationVeiwModel CreateSegment(float x, float y)
        {
            var locationModel = new LocationModel(x, y);
            var locationViewModel = new SegmentLocationViewModel(locationModel);
            var segmentObject = GameObject.Instantiate(_segmentPrefab);
            var locationView = segmentObject.AddComponent<LocationView>();
            locationView.Initialize(locationViewModel);

            return locationViewModel;
        }

        
    }
}
