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
