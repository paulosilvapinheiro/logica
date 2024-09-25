
class LapsCounter:
    countVolta = 0
    def __init__(self):
        self.countVolta = 0

    def zerar(self):
        self.countVolta = 0
    
    def volta(self):
        self.countVolta = self.countVolta + 1

    def totVoltas(self):
        return self.countVolta