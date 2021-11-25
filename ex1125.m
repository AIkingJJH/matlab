rng('default'); %random number generator
x=rand(1,25);
y= x+0.25+0.15*(2*rand(1,25)-1);

n=length(x);

A=[n,sum(x); sum(x), sum(x.^2)];
b=[sum(y); sum(x.*y)];
    
%A=zeros(2); %2x2행렬
%b=zeros(2,1);
for i=1:n
    A(1,1)=A(1,1)+1;
    A(1,2)=A(1,2)+x(i);
    A(2,2)=A(2,2)+x(i)^2;
    b(1)=b(1)+y(i);
    b(2)=b(2)+x(i)*y(i);
end
%A(1,1)=n;
%A(1,2)=sum(x);
%A(2,2)=sum(x.^2);
%b(1)=sum(y); b(2)=sum(x.*y);

aa=A\b; a0=aa(1); a1=aa(2);

A(2,1)=A(1,2);
D=A(1,1)*A(2,2)-A(1,2)*A(2,1);
a0=(A(2,2)*b(1)-b(2)*A(2,1))/D;
a1=(A(1,1)*b(2)-b(1)*A(1,2))/D;
t=linspace(0,1);
plot(x,y,'o',t,a0+a1*t,'r-');

