# Reto #0: EL FAMOSO "FIZZ BUZZ"

# 
# Escribe un programa que muestre por consola (con un print) los
# números de 1 a 100 (ambos incluidos y con un salto de línea entre
# cada impresión), sustituyendo los siguientes:
# - Múltiplos de 3 por la palabra "fizz".
# - Múltiplos de 5 por la palabra "buzz".
# - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
# 


def fizz_buzz():
    for n in range(100):
        print("fizz" * ( n%3==0 ) + "buzz" * ( n%5==0 ) or n)


if __name__ == '__main__':
    fizz_buzz()
