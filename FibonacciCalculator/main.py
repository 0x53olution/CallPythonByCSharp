import modules
import sys

n = sys.argv[1]

def start(n):
    myFibNo = modules.FibonacciNumbers(n)
    result = myFibNo.calc()
    print(result)
    print("Finished")
    
