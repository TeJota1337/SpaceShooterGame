using UnityEngine;

public class SpawnInimigos : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public float tempoDeSpawn = 2f;
    public float distanciaDeBusca = 10f;

    private Transform playerTransform;
    private float tempoPassado = 0f;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        tempoPassado += Time.deltaTime;
        if (tempoPassado >= tempoDeSpawn)
        {
            tempoPassado = 0f;
            InstanciarInimigo();
        }
    }

    private void InstanciarInimigo()
    {
        Vector3 posicaoDeSpawn = transform.position;
        GameObject novoInimigo = Instantiate(inimigoPrefab, posicaoDeSpawn, Quaternion.identity);
    }
}