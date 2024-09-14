#include<iostream>
using namespace std;

/*
 * Escribe un programa que, dado un n�mero, compruebe y muestre si es primo, fibonacci y par.
 * Ejemplos:
 * - Con el n�mero 2, nos dir�: "2 es primo, fibonacci y es par"
 * - Con el n�mero 7, nos dir�: "7 es primo, no es fibonacci y es impar"
 */

void fibonacci(int);
void primo(int);
void par(int);



int main(){
	int numero;
	
	cout<<"Coloca un numero: "; cin>>numero;
	
	fibonacci(numero);
	primo(numero);
	par(numero);
	
	
	
	
	
	return 0;
}

void fibonacci(int n){
	int a=0, b=1,c=0;
	
	do{
		c= a+b;
		b=a;
		a=c;		
	
	}while(c!=n and c <= n);
	
	if(c == n){
		cout<<"Es fibonacci, ";
	}
	
	else{
		cout<<"No es fibonacci, ";
	}
}

void primo(int n){
	
	int div=0;
	
	if(n < 2){
		
	}
	
	else{
		
		for(int i=2; i<n; i++){
			if(n%i == 0){
				div++;
				n= n/i;
			}
		}
	}
	
	
	if(div < 1){
		cout<<"El numero es primo, ";
	}
	
	else{
		cout<<"El numero no es primo, ";
	}
	
}

void par(int n){
	
	if(n%2 == 0){
		cout<<"El numero es par.";
	}
	
	else{
		cout<<"El numero es impar.";
	}
	
	
}
