n = int(input())
lista = []
for c in range(0, n):
  entrada = input().split(" ")
  p = float(entrada[0])
  g = int(entrada[1])
  valor = (p*1000)/g
  lista.append(valor)
menor = lista[0]
for int in lista:
  if int < menor:
    menor = int
print(f"{menor:.2f}")
