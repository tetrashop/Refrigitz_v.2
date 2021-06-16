clc;
clear all;
close all;
j=6;
Row=6;
Column=6;
A1=zeros(Row,Column);
A=zeros(Row,Column);
A2=zeros(Row,Column);
T21=zeros(Row,Column);
T22=zeros(Row,Column);
T=zeros(j,Row);
T4=zeros(j,Row);
T3=zeros(j,1);
k=zeros(j,1);
for i=1:j
k(i,1)=10^(-i);
end
for i=1:j
for a=11:10+Row
    for b=1:Column        
        e=sqrt(1-power(b/a,2));              
        c=sqrt(power(a,2)-power(b,2));
        p=a*(1-power(e,2));
dt=0;
teta=0;
teta0=pi-atan(b/c);
while teta<=teta0
   
    dr=(((-p*e*sin(teta))/power((1+e*cos(teta)),2)))*(10^(-i));
    r=p/(1+e*cos(teta));    
    dx=r*(10^(-i));
    dt=dt+sqrt(dx*dx+dr*dr);
    teta=teta+(10^(-i));    
end;
A1(a-10,b)=4*dt;
teta=0;
T21(a-10,b)=(2*p)*(teta*log(1+e*cos(teta))+(2/sqrt(1-power(e,2)))*teta*sin(teta)*atan(sqrt((1-e)/(1+e))*tan(teta/2))+((2*e)/(sqrt(1-power(e,2))))*cos(teta)*atan(sqrt((1-e)/(1+e))*tan(teta/2))-(2/(1-((1-e)/(1+e))))*((2*e)/(sqrt(1-power(e,2))))*teta+sqrt((1-e)/(1+e))*((2*e)/(sqrt(1-power(e,2))))*((2*(1+((1-e)/(1+e))))/(1-((1-e)/(1+e))))*atan(sqrt((1-e)/(1+e))*tan(teta/2))-((2*e)/(sqrt(1-power(e,2))))*((power(sqrt((1-e)/(1+e)),5)-5*sqrt((1-e)/(1+e)))/((1-(power(sqrt((1-e)/(1+e)),4)))*(power(sqrt((1-e)/(1+e)),2)+1)))*power(teta,2)*sin(teta)-(((2*e)/(sqrt(1-power(e,2))))*((10*(sqrt((1-e)/(1+e)))-(2*power((sqrt((1-e)/(1+e))),5)))/((1-(power(sqrt((1-e)/(1+e)),4)))*(power(sqrt((1-e)/(1+e)),2)+1))))*cos(teta)-((2*e)/sqrt(1-power(e,2)))*(((4*(sqrt((1-e)/(1+e)))-4*power((sqrt((1-e)/(1+e))),3)))/(power(1-(power((sqrt((1-e)/(1+e))),2)),2)*power(1+(power((sqrt((1-e)/(1+e))),2)),2)))*power(teta,2)*atan(sqrt((1-e)/(1+e))*tan(teta/2))+((2*e)/(sqrt(1-power(e,2))*((8-(12*(power(sqrt((1-e)/(1+e)),2))))/(3*(power(1-(power(sqrt((1-e)/(1+e)),2)),2))*((1+(power(sqrt((1-e)/(1+e)),2))))))))*power(teta,3)+teta)+power(p/(1+e*cos(teta)),2)+p/(1+e*cos(teta));
teta=pi-atan(b/c);
T22(a-10,b)=(2*p)*(teta*log(1+e*cos(teta))+(2/sqrt(1-power(e,2)))*teta*sin(teta)*atan(sqrt((1-e)/(1+e))*tan(teta/2))+((2*e)/(sqrt(1-power(e,2))))*cos(teta)*atan(sqrt((1-e)/(1+e))*tan(teta/2))-(2/(1-((1-e)/(1+e))))*((2*e)/(sqrt(1-power(e,2))))*teta+sqrt((1-e)/(1+e))*((2*e)/(sqrt(1-power(e,2))))*((2*(1+((1-e)/(1+e))))/(1-((1-e)/(1+e))))*atan(sqrt((1-e)/(1+e))*tan(teta/2))-((2*e)/(sqrt(1-power(e,2))))*((power(sqrt((1-e)/(1+e)),5)-5*sqrt((1-e)/(1+e)))/((1-(power(sqrt((1-e)/(1+e)),4)))*(power(sqrt((1-e)/(1+e)),2)+1)))*power(teta,2)*sin(teta)-(((2*e)/(sqrt(1-power(e,2))))*((10*(sqrt((1-e)/(1+e)))-(2*power((sqrt((1-e)/(1+e))),5)))/((1-(power(sqrt((1-e)/(1+e)),4)))*(power(sqrt((1-e)/(1+e)),2)+1))))*cos(teta)-((2*e)/sqrt(1-power(e,2)))*(((4*(sqrt((1-e)/(1+e)))-4*power((sqrt((1-e)/(1+e))),3)))/(power(1-(power((sqrt((1-e)/(1+e))),2)),2)*power(1+(power((sqrt((1-e)/(1+e))),2)),2)))*power(teta,2)*atan(sqrt((1-e)/(1+e))*tan(teta/2))+((2*e)/(sqrt(1-power(e,2))*((8-(12*(power(sqrt((1-e)/(1+e)),2))))/(3*(power(1-(power(sqrt((1-e)/(1+e)),2)),2))*((1+(power(sqrt((1-e)/(1+e)),2))))))))*power(teta,3)+teta)+power(p/(1+e*cos(teta)),2)+p/(1+e*cos(teta));
A2(a-10,b)=4*sqrt(T22(a-10,b)-T21(a-10,b));
end;
end;
A=real(A1-A2);
T3(i)=((((((sum(sum(abs(A1)))-sum(sum(abs(A2))))))/sum(sum(abs(A2)))))/50)*100;
T(i,:)=(var(A1))-(var(A2));
a1=1:5;
b1=1:5;
end;
R=surf(A);
%R=imread('D:\Users\Ramin\Desktop\Differencies.jpg');
%hist(R);
%hist(H);

%S=plot3(a1,b1,A);
%hist(S);
M=plot(T);    
%hist(M);


    
    