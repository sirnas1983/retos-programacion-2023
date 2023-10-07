'''
 Crea una función que encuentre todas las combinaciones de los números
 de una lista que suman el valor objetivo.
 - La función recibirá una lista de números enteros positivos
   y un valor objetivo.
 - Para obtener las combinaciones sólo se puede usar
   una vez cada elemento de la lista (pero pueden existir
   elementos repetidos en ella).
 - Ejemplo: Lista = [1, 5, 3, 2],  Objetivo = 6
   Soluciones: [1, 5] y [1, 3, 2] (ambas combinaciones suman 6)
   (Si no existen combinaciones, retornar una lista vacía)
 '''


def find_combinations(lst: list, target: int) -> list:
    def find_sum(start: int, target: int, nums: list):

        # Solución
        if target == 0:
            # Si el objetivo se alcanza (es igual a cero), se agrega la combinación a la lista de resultados.
            combinations.append(nums)
            return

        # No hay solución
        if target < 0 or start == len(lst):
            # Si el objetivo es negativo o hemos llegado al final de la lista, detenemos la recursión.
            return

        # Búsqueda
        # Se itera a través de los elementos de la lista a partir del índice 'start'.
        for i in range(start, len(lst)):

            if i > start and lst[i] == lst[i - 1]:
                continue

            # Se llama recursivamente con el próximo número y el nuevo objetivo.
            find_sum(i + 1, target - lst[i], nums + [lst[i]])

    lst.sort()
    # Se crea una lista para almacenar las combinaciones válidas.
    combinations = []
    # Se llama a la función auxiliar con los valores iniciales.
    find_sum(0, target, [])
    # Se devuelve la lista de combinaciones válidas al finalizar.
    return combinations


if __name__ == '__main__':
    lista = [1, 1, 1, 1, 2]
    objetivo = 6
    print(find_combinations(lista, objetivo))
