#include <iostream>

using namespace std;

int main(){
     
    //TIPO NOME;
    //TIPO NOME = VALOR;
    
    int vidas = 0; //10, 25, 100, 0, -2;
    char letra = 'a'; //'a','b', 'R', 'A';
    char letras[20];
    double decimal = 1.4545; //1.543422, 2.6654, 1.9996776;
    float decimal2 = 1.5; //1.5, 2.5; 
    bool vivo = true; //true=verdadeiro / false=falso;
    string nome = "Fabio"; //"Fabio Leal Schmitz", "Luiz";
    
    cout << "Digite o numero de vida: ";
    cin >> vidas;
    cout << "Digite uma letra: ";
    cin >> letra;
    cout << "Digite o Dinheiro: ";
    cin >> decimal;
    cout << "Digite o nome: ";
    cin >> nome;

    cout << "\nVidas: " << vidas << "\nLetra: " << letra << "\nDinheiro: " << decimal << "\nNa Conta: " << decimal2 << "\nVivo? " << vivo << "\nNome: " << nome << "\n";

    return 0;
}