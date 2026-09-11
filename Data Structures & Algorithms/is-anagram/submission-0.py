class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) == len(t):
            sorted_wrd1= "".join(sorted(s))
            sorted_wrd2= "".join(sorted(t))
            if sorted_wrd1 != sorted_wrd2:
                return False
            return True
        return False