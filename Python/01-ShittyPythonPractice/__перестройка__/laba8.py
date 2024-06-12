##### 1 #####
import numpy as np
print(np.zeros([15]))

##### 2 #####
import numpy as np
print(np.full([8], 3.2))

##### 3 #####
import numpy as np
v = np.zeros([15])
v[4] = 1
print(v)

##### 4 #####
import numpy as np
v = np.arange(start = 12, stop = 43)
print(v)

##### 5 #####
import numpy as np
print(np.random.random([3, 3, 2]))

##### 6 #####
import numpy as np
m = np.random.random([12, 12])
min_var2 = np.min(m)
max_var2 = np.max(m)
print(min_var2)
print(max_var2)

##### 7 #####
import numpy as np
Z = np.zeros((10,10))
Z[1:-1,1:-1] = 1
print(Z)

##### 8 #####
import numpy as np
m = np.zeros([8, 8])
m[::2, ::2] = 1
m[1::2, 1::2] = 1
print(m)

##### 9 #####
import numpy as np
m1 = np.tile(A=np.array([[1,0], [0,1]]), reps=[4,4])
print(m1)

##### 10 #####
import numpy as np
a = np.random.random([4, 2])
b = np.random.random([2, 5])
print(np.dot(a, b))

##### 11 #####
import numpy as np
m = np.random.randint(low=4, high=7, size=[5,5])
m[(m > 4) & (m < 7)] *=-1
print(m)

##### 12 #####
import numpy as np
m = np.zeros([6,6])
m += np.arange(6)
print(m)
print(m.dtype)

##### 13 #####
import numpy as np
v = np.random.random(size=[5])
print(v)
v = np.sort(a=v, axis=0)
print(v)

##### 14 #####
import numpy as np
a = np.array([1,2,3,4,5])
b = np.array([1,2,3,4,6])
print(np.array_equal(a,b))
print(np.allclose(a,b))

##### 15 #####
import numpy as np
a = np.array([[0, 1], [2, 3], [4, 5], [6, 7], [9, 8]])
b = np.zeros_like(a)
b[np.arange(len(a)), a.argmax(1)] = -1
print(b)

##### 16 #####
import numpy as np
def find_nearest(array, value):
    array = np.asarray(array)
    idx = (np.abs(array - value)).argmin()
    return array[idx]
    
array = np.random.random(10)
print(array)
print(find_nearest(array, value=0.5))

##### 17 #####

##### 18 #####
import numpy as np
m = np.random.randint(low=1, high=100, size=[3,3])
print('массив:')
print(m)
print('средние значения каждой строки матрицы')
print(m.mean(axis=1))

##### 19 #####
import numpy as np
a = np.array([[4,3,1], [5,7,0], [9,9,3], [8,2,4]])

print(a) 
print() 

a[[0, 2]] = a[[2, 0]]
print(a)

##### 20 #####
import numpy as np

def distance(P0, P1, p):
    T = P1 - P0
    L = (T**2).sum(axis=1)
    U = -((P0[:,0]-p[...,0])*T[:,0] + (P0[:,1]-p[...,1])*T[:,1]) / L
    U = U.reshape(len(U),1)
    D = P0 + U*T - p
    return np.sqrt((D**2).sum(axis=1))

P0 = np.random.uniform(-10,10,(10,2))
P1 = np.random.uniform(-10,10,(10,2))
p  = np.random.uniform(-10,10,( 1,2))
print(distance(P0, P1, p))

##### 21 #####
import numpy as np
arr = np.array([2, 0,  1, 5,
                4, 1, 9])
print(arr)
sorted_index_array = np.argsort(arr)
sorted_array = arr[sorted_index_array]
  
print(sorted_array)
n = 1
rslt = sorted_array[-n : ]
print("{} НАИБОЛЬШЕЕ:".format(n), rslt[0])

##### 22 #####
import numpy as np

a = np.array([1,2,3,4,5,6])
b = np.array([1,4,5])

c = np.in1d(a,b)
print(c)

##### 23 #####

##### 24 #####

##### 25 #####
