N=51;
x=linspace(-2,2,N);
y=linspace(-2,2,N);

[xx,yy]=ndgrid(x,y);

ff=2*xx.^2+3*yy.^2;

clf;
contour(xx,yy,ff);
axis image; grid on; hold on;

alpha=0.1;
oldx=[1,1];
plot(oldx(1), oldx(2), 'rs');

for it=1:5
    gradf=[4*oldx(1),6*oldx(2)];
    newx=oldx-alpha*gradf;
    
    oldx=newx;
    plot(oldx(1), oldx(2), 'o');
end
hold off;
    