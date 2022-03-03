#!/usr/bin/env python
# coding: utf-8

# 실행x

# In[14]:


print('hello world')


# In[15]:


print(3.14)


# In[17]:


print('phi=',3.14)


# In[28]:


print('phi=3.14')


# 포맷함수

# In[29]:


s3 = 'number : {num}, gender : {gen}'.format(num=1234, gen='남')
print(s3)


# 람다함수

# In[27]:


f= (lambda x,y: x + y)(10, 20)
f


# In[30]:


a=1
b=2
c=3
a+b+c


# 변수 정의:벡터, 행렬
# 
# 변수명 규칙: 영문자(대소문자 구분,숫자,_(underbar),숫자부터 올 수 없음.

# In[46]:


import numpy as np
aa=np.array((1,1,1))
bb=np.array([[1],[1],[1]])
print(aa)
print(bb)
print(aa*bb)
print(bb)


# 논리연산 and or not

# In[56]:


print(2>1)
print(2<1)
print(2>=1)
print(2>1 and 3>1)
print(2<1 or 3>1)
print(not 2<1)
print(1==1)


# Loop (for , while)

# In[83]:


for i in range(10):
    print(i)
    
    if i==5:
        break


# In[81]:


i=0
while i<5 :
    i=i+1
    print(i)


# In[ ]:




