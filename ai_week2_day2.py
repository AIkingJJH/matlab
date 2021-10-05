# Load CSV Using Python Standard Library
import csv
import numpy
filename = "pv_04.csv"
with open(filename, newline='') as csvfile:
    reader = csv.reader(csvfile, delimiter=',', quotechar='\"')
    for row in reader:
        print(row)
       # print(', '.join(row))
       
       # Load CSV Using Python Standard Library 
import csv 
import numpy 
filename = "pv_04_float.csv"
with open(filename, "rt") as csvfile:
    reader = csv.reader(csvfile, delimiter=',', quotechar='\"')
    # print(reader)
    #for row in reader:
        #print(row)
        # print(', '.join(row))

    xy = list(reader)
xy


# print(xy)
xy
# print(data.shape)
data = numpy.array(xy)
print(data.shape)
type(data[2][2])



# 데이터 Type 변환
dataf = numpy.array(xy).astype('float')
print(data.shape)
type(dataf[2][2])


# Load CSV using NumPy
from numpy import loadtxt
filename ='pv_04_float.csv'
raw_data = open(filename,'rt')
data = loadtxt(raw_data, delimiter=",")
print(data.shape)
data


# Load CSV using Pandas 오류가 난다. ANSI 코드를 쓰고 있기 때문임. 이런 오류가 잦으니까 잘 경험해두기
from pandas import read_csv
filename ='pv_04.csv'
names = ['일자','외기온도','모듈온도','일사량','전압','전류','내부온도','단자온도']
data = read_csv(filename) #, names=names)
print(data.shape)
data

# Load CSV using Pandas 위와 다른점은 파일을 utf8로 인코딩해줘야되기 때문.(메모장>다른이름으로저장>인코딩 + 파일형식도 모든파일로 바꿔서 csv확장자 유지)
from pandas import read_csv
filename ='pv_04_utf8.csv'
names = ['일자','외기온도','모듈온도','일사량','전압','전류','내부온도','단자온도']
data = read_csv(filename) #, names=names)
print(data.shape)
data

# Load CSV using Pandas from URLfrom pandas 
from pandas import read_csv
url ='http://localhost/pv_04.csv'
names = ['일자','외기온도','모듈온도','일사량','전압','전류','내부온도','단자온도']
data = read_csv(url, names=names)
print(data.shape)
data
