import unittest

class Life:
   def rocks(self):
       return "rocks"

class LifeTest(unittest.TestCase):
   def setUp(self):
       self.life = Life()

   def test_rocks(self):
       self.assertEquals("rocks", self.life.rocks())

if __name__ == '__main__':
  unittest.main()
