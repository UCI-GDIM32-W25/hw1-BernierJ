using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
       // movement
        
        _playerTransform.Translate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * _speed * Time.deltaTime);
        

        //plant a plant
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeeds > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);

            _numSeeds--;
            _numSeedsLeft = _numSeeds;
            _numSeedsPlanted++; 
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

            
            
        }
    }
}
