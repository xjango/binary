def binary(num):
 array = [128,64,32,16,8,4,2,1]
 end = ""
 v = 0
 z = 0
 count = 0
 while count < len(array):
    z = v + array[count]
    if z <= num:
        v=z;
        end += "1"
    else:
        end += "0"
    count = count + 1
 return end


print binary(22);
