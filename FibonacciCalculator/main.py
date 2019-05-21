import modules
import sys


def start(n):
    myFibNo = modules.FibonacciNumbers(n)
    result = myFibNo.calc()
    print(result)
    print("Finished")


if __name__ == "__main__":
    start(int(sys.argv[1]))
