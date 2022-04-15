clear; 
rand('seed', 50);
X = [1; 2; 2; 2; 3]; aa = [3; 5; 3; 1; 3]; t = [0; 0; 1; 0; 1];
w= [rand(1) rand(1) rand(1) ;rand(1) rand(1) rand(1)];
v= [rand(1) rand(1) rand(1)];

Tol = 1.0e-7; Resid = 2*Tol;
eta = 2.5; MaxIter = 1.0e7;
p = @(uu) 1./(1+exp(-uu));
Dp = @(uu) exp(-uu)./(1+exp(-uu)).^2;
E = @(yy, tt) sum(0.5*(yy-tt).^2)/5;

E1 = 100;

n = 1;
y = zeros(size(t));
while Resid>=Tol & n<=MaxIter
    for i = 1:length(X)

        input=[1; X(i); aa(i)];
        uh = w*input; %uh 2x1
        z = p(uh);
        z = [1; z];
        uo = v*z;
        y(i) = p(uo);

%         dEdw = ((y(i) - t(i)))*Dp(uo)*(Dp(uh).*v(2:end))*[input'; input'];
        dEdw = ((y(i) - t(i)))*Dp(uo)*(Dp(uh).*(v(2:end)')).*input';
        
        dEdv= ((y(i) - t(i)))*Dp(uo)*z';

        w = w-eta*dEdw;
        v = v-eta*dEdv;

    end
    for i = 1:length(X)

        input=[1; X(i); aa(i)];
        uh = w*input; %uh 2x1
        z = p(uh);
        z = [1; z];
        uo = v*z;
        y(i) = p(uo);
    end

    E2 = E(y, t);
    Resid = abs(E2 - E1);
    E1 = E2;
    n = n+1;

    if mod(n, 1000) == 0
        fprintf('y(%d) = {%f, %f, %f, %f, %f}, E(y, t) = %f \n', ...
            n, y(1), y(2), y(3), y(4), y(5), E1);
    end
end

fprintf('y(%d) = {%f, %f, %f, %f, %f}, E(y, t) = %f \n', n, y(1), y(2), y(3), y(4), y(5), E1);

[xx,yy]=ndgrid(0:0.1:4, (0:0.1:6)-0);

uu1=p(w(1)+w(3)*xx+w(5)*yy);
uu2=p(w(2)+w(4)*xx+w(6)*yy);

uuu1=p(v(1)*1+v(2)*uu1+v(3)*uu2);

figure(1)
clf;

plot(X(t==1),aa(t==1),'ro');
hold on;
plot(X(t==0),aa(t==0),'bo');

contour(xx,yy,uuu1,[0.5,0.5]);

hold off; grid on;