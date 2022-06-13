entrada = input().split(' ')
n = int(entrada[0])
i = int(entrada[1])
f = int(entrada[2])
vetor = input().split()
cont = 0
for c in range(0, n-1):
  v = int(vetor[c])
  for j in range(c+1, n):
    v1 = int(vetor[j])
    soma = v+ v1
    if soma <= f and soma >= i:
      cont +=1
print(cont)
