class Solution:
    def merge(self, nums1, m, nums2, n):
        nums1 = [x for x in nums1 if x != 0]
        nums2 = [x for x in nums2 if x != 0]
        if n == 0:
            return nums1
        elif m == 0:
            return nums2
    
        # if m < m + n:
        #     for i in range(m, m + n):
        #         nums1.append(0)
        
        for N in range(len(nums2)):
            for M in range(len(nums1)):           
                if nums1[M] > nums2[N]:
                    nums1.insert(M,nums2[N])
                    break
                if max(nums1) <= nums2[N]:
                    nums1.append(nums2[N])
                    break

        return nums1



s = Solution()
nums1 = [1,2,3,7,8]
nums2 = [1,2,5,6,6]
m = 5
n = 5
r = s.merge(nums1,m,nums2,n)
print(r)
