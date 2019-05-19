class FibonacciNumbers:
    """Calulates the fibonacci sequence
    F(n) = F(n-1) + F(n-2) for n>1

    Args:
        arg n (int) the last possible number in fibonacci series
    """

    def __init__(self, n):
        self.n = n

    def calc(self):
        """Calculates the fibonacci series up to a specific number

        Returns:
            List of fibonacci numbers
        """
        result = []
        a, b = 0, 1
        while a < self.n:
            result.append(a)
            a, b = b, a+b
        return result
