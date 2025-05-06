using UnityEngine;
public class Henrique : Claudia{
    // Oi mãezinha, feliz dia das mães <3
    // Eu e a Aline pensamos em mandar uma carta pras nossas mães no dia das mães
    // Mas eu não sou tão bom com as palavras e sou mt bobo.
    // Tive algumas ideias, mas minha ideia mais boba foi essa.
    // Fazer um código q desenha um coração e escrever ele a mão e te mandar.
    // Pra ver ele em prática site "hique.itch.io/mae" senha "teamo"
    public LineRenderer linha;
    void Update(){
        if(Input.touchCount > 0)
            Coracao();
    }
    void Coracao(){
        int pontos = 100;
        float escala = 1.5f;
        linha.positionCount = pontos + 1;
        for (int i = 0; i <= pontos; i++){
            float t = 2f * Mathf.PI * i / pontos;
            float x = 16f * Mathf.Pow(Mathf.Sin(t), 3);
            float y = 13f * Mathf.Cos(t) - 5f * Mathf.Cos(2f * t) - 2f * Mathf.Cos(3f * t) - Mathf.Cos(4f * t);
            linha.SetPosition(i, new Vector3(x, y, 0) * escala * 0.1f);
            }
        linha.loop = true;
    }
}