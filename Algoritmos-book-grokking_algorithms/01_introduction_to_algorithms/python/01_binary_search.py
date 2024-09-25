
import sys 
from pathlib import Path
file = Path(__file__).resolve()
parent, root = file.parent, file.parents[2]
sys.path.append(str(root))

# from LapsCounter import *
import LapsCounter as lc 

lapsCounter = lc.LapsCounter()


def simple_search(list, item):
  #Itera sequencialmente até achar o 
  for x in range(len(list)):
    lapsCounter.volta()
    if list[x] == item:
      return x
    
  # Item doesn't exist
  return None

def binary_search(list, item):
  # low and high keep track of which part of the list you'll search in.
  low = 0
  high = len(list) - 1

  # While you haven't narrowed it down to one element ...
  while low <= high:
    lapsCounter.volta()

    # ... check the middle element
    mid = (low + high) // 2
    guess = list[mid]
    # Found the item.
    if guess == item:
      return mid
    # The guess was too high.
    if guess > item:
      high = mid - 1
    # The guess was too low.
    else:
      low = mid + 1

  # Item doesn't exist
  return None

my_list = [1, 3, 5, 7, 9, 15, 16, 17, 19, 20]
vlProcurado = 20

print(f"Algoritmo SIMPLE_SEARCH (Valor procurado [ {vlProcurado} ]): Localizado no indice [ {simple_search(my_list, vlProcurado)} ] | Total de voltas [ {lapsCounter.totVoltas()} ]")

lapsCounter.zerar()

# print (binary_search(my_list, 9)) # => 1
print(f"Algoritmo BINARY_SEARCH (Valor procurado [ {vlProcurado} ]): Localizado no indice [ {binary_search(my_list, vlProcurado)} ] | Total de voltas [ {lapsCounter.totVoltas()} ]")

# 'None' means null in Python. We use to indicate that the item wasn't found.
print (binary_search(my_list, -1)) # => None


