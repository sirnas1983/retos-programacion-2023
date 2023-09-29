'''
 Crea las funciones capaces de transformar colores HEX
 a RGB y viceversa.
 Ejemplos:
 RGB a HEX: r: 0, g: 0, b: 0 -> #000000
 HEX a RGB: hex: #000000 -> (r: 0, g: 0, b: 0)
 '''


def hex2rgb(hex: str) -> tuple[int, int, int]:
    '''La función `hex2rgb` toma un código de color hexadecimal como entrada y devuelve un diccionario que
    contiene los valores RGB correspondientes.

    Parametros
    ----------
    hex : str
        El parámetro "hex" es una cadena que representa un código de color hexadecimal.

    Returns
    -------
        La función `hex2rgb` devuelve un diccionario con las claves 'r', 'g' y 'b' que representan los
    valores rojo, verde y azul respectivamente. Si hay un ValueError que indica un valor hexadecimal no
    válido, la función devuelve Ninguno.

    '''
    try:
        r = int(hex[1:3], 16)
        g = int(hex[3:5], 16)
        b = int(hex[5:8], 16)

        return (r, g, b)

    except ValueError as error:
        print(f'Error: {error}')
        return (0, 0, 0)


def rgb2hex(r: int, g: int, b: int) -> str:
    '''La función `rgb2hex` convierte valores RGB a un código de color hexadecimal.
    
    Parameters
    ----------
    r : int
        El parámetro `r` representa el componente rojo del color RGB. Debe ser un valor entero entre 0 y
    255.
    g : int
        El parámetro `g` representa el componente verde del color RGB.
    b : int
        El parámetro `b` representa el componente azul del color RGB. Es un valor entero que va de 0 a 255,
    que indica la intensidad del azul en el color.
    
    Returns
    -------
        La función `rgb2hex` devuelve una cadena que representa el código de color hexadecimal de los
    valores RGB dados.
    
    '''
    r = max(0, min(255, r))
    g = max(0, min(255, g))
    b = max(0, min(255, b))

    return f"#{r:02x}{g:02x}{b:02x}".upper()


def main():
    opcion = int(input('1 - HEX to RGB, 2 - RGB to HEX: '))

    match opcion:
        case 1:
            hex_value = input('Hex color (E.g.: #3250A8): ')
            rgb = hex2rgb(hex_value)
            print(f'{hex_value} -> {rgb}')

        case 2:
            r = int(input('R (0-255): '))
            g = int(input('G (0-255): '))
            b = int(input('B (0-255): '))

            hex_value = rgb2hex(r, g, b)
            print(f'(r: {r}, g: {g}, b: {b}) -> {hex_value}')


if __name__ == "__main__":
    main()
