v = int(input())
p = int(input())
parcela = v // p
resto = v % p
for c in range(0, p):
  if resto != 0:
    print(parcela+1)
    resto -= 1
  else:
    print(parcela)
