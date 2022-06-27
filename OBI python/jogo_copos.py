n = int(input())
pos = input()
for c in range(0, n):
  mov = int(input())
  if (mov == 1 and pos == 'A') or (mov == 2 and pos == 'C'):
    pos = 'B'
  if (mov == 1 and pos == 'B') or (mov == 3 and pos == 'C'):
    pos = 'A'
  if (mov == 2 and pos == 'B') or (mov == 3 and pos =='A'):
    pos == 'C'
print(pos)
