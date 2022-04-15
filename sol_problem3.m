clc;
clear;
X=[1; 2; 3; 4; 5; 6; 7; 8; 9; 10]; T1=[0 0 1 1 0 0 0 1 0 0]; T2=[0 0 0 0 1 0 0 0 1 1];
 
w1=[rand(1) rand(1); rand(1) rand(1); rand(1) rand(1); rand(1) rand(1);rand(1) rand(1)]; 
v1=[rand(1) rand(1) rand(1) rand(1) rand(1) rand(1)];
v2=[rand(1) rand(1) rand(1) rand(1) rand(1) rand(1)];

Tol=1.0e-7; Resid=Tol*2;
eta=0.05;
MaxIter=1.0e6; 
p=@(uu) 1./(1+exp(-uu));
Dp=@(uu) exp(-uu)./(1+exp(-uu)).^2;
E=@(yy,tt,yyy,ttt) sum(0.5*(yy-tt).^2)/10 + sum(0.5*(yyy-ttt).^2)/10;

E1=1000;

n=1;
while Resid>=Tol && n<=MaxIter
    for m=1:length(T1)
        
        x=[1;X(m)]; %x=2x1 
        
        uh=w1*x; %uh=5x1
       
        z=p(uh);%z=5x1
        
        z=[1;z];%z=6x1 
        
        uo1=v1*z;%uo1=1x1
        uo2=v2*z;%uo2=1x1
        
        y1(m)=p(uo1);%y1=1x1
        y2(m)=p(uo2);%y2=1x1
        
        dEdv1=(y1(m)-T1(m))*Dp(uo1)*z'; %y1에대한 경사하강법
        dEdv2=(y2(m)-T2(m))*Dp(uo2)*z';%y2에대한 경사하강법
        dEdw1=((y1(m)-T1(m))*Dp(uo1))*(Dp(uh)*Dp(uo1).*v1(2:end)')*x' + ((y2(m)-T2(m))*Dp(uo2))*(Dp(uh)*Dp(uo2).*v2(2:end)')*x';
        
        w1=w1-eta*dEdw1; 
        v1=v1-eta*dEdv1;
        v2=v2-eta*dEdv2;
        
        
    end
    for m=1:length(T1)        
       x=[1;X(m)];
        uh=w1*x;
        z=p(uh);
        z=[1;z];
        uo1=v1*z;
        uo2=v2*z;
        
        y1(m)=p(uo1);
        y2(m)=p(uo2);
    end
    E2=E(y1,T1,y2,T2);
       
    Resid=abs(E2-E1);
        
    E1=E2;
   
    
    n=n+1;
    
    if(mod(n,100)==0)
                 
        fprintf('y1(%d)={%f,%f,%f,%f,%f,%f,%f,%f,%f,%f}, E(X,W)=%f\n', ...
            n, y1(1),y1(2),y1(3),y1(4),y1(5),y1(6),y1(7),y1(8),y1(9),y1(10),E1);
         fprintf('y2(%d)={%f,%f,%f,%f,%f,%f,%f,%f,%f,%f}, E(X,W)=%f\n', ...
            n, y2(1),y2(2),y2(3),y2(4),y2(5),y2(6),y2(7),y2(8),y2(9),y2(10),E1);
    end
end
fprintf('y1(%d)={%f,%f,%f,%f,%f,%f,%f,%f,%f,%f}, E(X,W)=%f\n', ...
            n, y1(1),y1(2),y1(3),y1(4),y1(5),y1(6),y1(7),y1(8),y1(9),y1(10),E1);
        fprintf('y2(%d)={%f,%f,%f,%f,%f,%f,%f,%f,%f,%f}, E(X,W)=%f\n', ...
            n, y2(1),y2(2),y2(3),y2(4),y2(5),y2(6),y2(7),y2(8),y2(9),y2(10),E1);

        
[xx,yy]=ndgrid(1:0.1:10, -10:0.1:10);

uu1=p(w1(1)+w1(6)*xx) ;
uu2=p(w1(2)+w1(7)*xx) ;
uu3=p(w1(3)+w1(8)*xx) ;
uu4=p(w1(4)+w1(9)*xx) ;
uu5=p(w1(5)+w1(10)*xx) ;
uuu1=v1(1)+v1(2)*uu1+v1(3)*uu2+v1(4)*uu3+v1(5)*uu4+v1(6)*uu5;
uuu2=v2(1)+v2(2)*uu1+v2(3)*uu2+v2(4)*uu3+v2(5)*uu4+v2(6)*uu5;
figure(1)
clf;
grid on;

plot(X(T1==1 & T2==0),yy(T1==1),'ro');
hold on;
plot(X(T1==0 & T2==1),yy(T1==1),'go');

plot(X(T1==0 & T2==0),yy(T1==0 & T2==0),'bo');

%plot(X(T2==1),yy(T2==1),'ro');


%plot(X(T2==0),yy(T2==0),'bo');

contour(xx,yy,uuu1,[-0.03,-0.03],'ro');
contour(xx,yy,uuu2,[-0.5,-0.5],'bo');
hold off