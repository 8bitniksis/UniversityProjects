clc;
clear all;
close all;
figure;
pause(2);
t=0:0.01:2*pi;
x2=2.6*cos(t);
y2=2.6*sin(t);
plot(x2,y2,'b','linewidth',4);
axis square;
pause(1);
hold on;
temp=1;
t=2*pi:-2*pi/12:0;
x=cos(t);
y=sin(t);
x1=2*cos(t);
y1=2*sin(t);
x3=2.3*cos(t);
y3=2.3*sin(t);
g=[3 4 5 6 7 8 9 10 11 12 1 2];
for i=1:length(t)
    m=x(i);
    n=y(i);
    a=x1(i);
    b=y1(i);
    plot([m a],[n,b],'r');
    str=int2str(g(temp));
    text(x3(i),y3(i),str,'Color','black','FontSize',20);
    if(temp<length(g))
    temp=temp+1;
    else
        temp=1;
    end
    pause(0.9);
    axis square;
    hold on;
end