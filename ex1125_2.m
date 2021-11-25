rng('default'); %random number generator
x=4*rand(1,25);
y=0.25*exp((1.15+0.1*(2*rand(1,25)-1)).*x);

X=x;
Y=log(y);
%plot(X,Y,'o');


n=length(X);
A=[n,sum(X); sum(X), sum(X.^2)];
b=[sum(Y); sum(X.*Y)];
aa=A\b; a0=aa(1); a1=aa(2);

a=a1; b=exp(a0);

t=linspace(0,4);
plot(x,y,'o',t,b*exp(a*t),'r-');


    