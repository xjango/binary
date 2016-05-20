function binary(num)
{
var numbers = [128,64,32,16,8,4,2,1];
var end = "";
var v = 0;
var z = 0;
for(i = 0; i < 8;i++)
{
var z = v + numbers[i];
if(z <= num)
{
v = z;
end += "1";
} else {
end += "0";
}
}
return end;
}
document.write(binary("252"));
