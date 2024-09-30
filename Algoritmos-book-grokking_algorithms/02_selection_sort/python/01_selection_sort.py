import sys 
from pathlib import Path
file = Path(__file__).resolve()
parent, root = file.parent, file.parents[2]
sys.path.append(str(root))

# from LapsCounter import *
import LapsCounter as lc 

lapsCounter = lc.LapsCounter()

# Finds the smallest value in an array
def findSmallest(arr):
  # Stores the smallest value
  smallest = arr[0]
  # Stores the index of the smallest value
  smallest_index = 0
  for i in range(1, len(arr)):
    lapsCounter.volta()

    if arr[i] < smallest:
      smallest = arr[i]
      smallest_index = i
  return smallest_index

# Sort array
def selectionSort(arr):
  newArr = []
  for i in range(len(arr)):
      lapsCounter.volta()

      # Finds the smallest element in the array and adds it to the new array
      smallest = findSmallest(arr)
      newArr.append(arr.pop(smallest))
  return newArr

print(f"Algoritmo SELECTION SORT (Array [20, 5, 3, 6, 2, 10]): Ordenando [ {selectionSort([ 5, 3, 6, 2, 10, 1, 11])} ] | Total de voltas [ {lapsCounter.totVoltas()} ]")
# print (selectionSort([5, 3, 6, 2, 10]))
