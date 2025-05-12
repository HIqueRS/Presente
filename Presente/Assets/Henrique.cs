using UnityEngine;
public class Henrique : Claudia{
//Oi mãezinha! feliz dia das mães <3
//Pensei em te mandar uma carta de dia das mães.
//Mas eu não sou tão bom com as palavras.
//Tive algumas ideias a ideia mais boba foi essa.
//Escrever a mão um código q desenha coração.
public LineRenderer linha;
void Update(){
 if(Input.GetMouseButtonDown(0))
  Coracao();}
void Coracao(){
 linha.positionCount = 100 + 1;
 for (int i = 0; i <= 100; i++){
 float t = 2f * Mathf.PI * i / 100;
 float x = 16f * Mathf.Pow(Mathf.Sin(t), 3);
float y = 13f * Mathf.Cos(t) - 5f * Mathf.Cos(2f * t)
- 2f * Mathf.Cos(3f * t) - Mathf.Cos(4f * t);
linha.SetPosition(i, new Vector3(x, y, 0) * 1.5f * 0.1f);}}}
//te amo! espero que goste dessa bobagi
//pra ver ele funcionando entra no site
//site: "hique.itch.io/mae"
//senha: "TEAMO"
//beijinhos! bom domingo!