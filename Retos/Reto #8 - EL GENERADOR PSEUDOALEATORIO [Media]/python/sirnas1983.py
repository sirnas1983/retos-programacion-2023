import time

def random():
    now = str(time.time())
    sum = now[-2] + now[-1]
    rand = int(sum)
    time.sleep(0.00001)
    if rand == 1 or rand == 99:
        if random()>50 and rand == 99:
            rand += 1
        elif random()> 50 and rand == 1:
            rand -= 1
    return rand


# Pruebas
resp = []
for i in range(100):
    resp.append(random())
    time.sleep(0.0002)

print("Lista de numeros aleatorios:\n",resp)
print("Media aritmetica:",sum(resp)/len(resp))
print("Maximo:",max(resp))
print("Minimo:",min(resp))

# Lista de numeros aleatorios:
# [67, 14, 35, 3, 69, 16, 54, 14, 17, 16, 66, 3, 36, 61, 87, 15, 62, 6, 14, 67, 31, 63, 12, 15, 73, 51, 16, 43, 39, 23, 77, 15, 13, 43, 46, 98, 52, 62, 6, 0, 47, 42, 8, 47, 55, 21, 2, 24, 19, 100, 12, 
# 68, 93, 11, 79, 67, 22, 22, 49, 76, 31, 49, 33, 91, 57, 52, 71, 73, 46, 33, 75, 78, 92, 55, 67, 75, 
# 16, 59, 16, 62, 6, 91, 16, 74, 86, 63, 75, 98, 65, 48, 26, 66, 48, 43, 35, 84, 43, 86, 28, 56]      
# Media aritmetica: 46.32
# Maximo: 100
# Minimo: 0
