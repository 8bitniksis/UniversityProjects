%M-file 'fpanim.m' for Flow Plot animation:
function [sys,x0] = L0602Plot(t,x,u,flag,par_ts, xmax)
   global FPAnim %global counter handle
   % update model
   if flag==2
      % if get(0,'Children')==1 % test, if plot exists
           set(0,'currentfigure',FPAnim);
           ShowNext(par_ts,u(1));
           drawnow; % update plot
      % end
       sys=[];
   elseif flag == 4 % Return next sample hit
       sys = t + 10*par_ts; %the constant sample interval
   elseif flag==0,
       % Initialize the figure for use with this simulation
       animinit('Flow Plot Animation');
       FPAnim = findobj('Type','figure',...
           'Name','Flow Plot Animation');
       Init([0 xmax]);
       hold on
       % Init structure for Simulink
       sys=[0 0 0 1 0 0]; %1...number of inputs
       x0 = []; % No continuous states
   end;

function Init(xLim)
   global FP
   % new axis
   axis([xLim -1 1]); axis on;
   % structure initialisation
   FP= struct('axes',cla,'data',[xLim(1) NaN],...
       'xLim',xLim,'yLim',[-1 1]);
   set(FP.axes,'DrawMode','fast','Color','none',...
       'xLimMode','manual','yLimMode','manual');
   FP.line=line(0,NaN,'Erase','none');
   
% show current point
function ShowNext(dx,y)
   global FP
   % add new point
   x1=FP.data(end,1)+dx;
   FP.data= [FP.data; x1 y];
   % right shift
   if FP.xLim(2) < x1
       dx= x1-FP.xLim(2);
       FP.xLim= FP.xLim + dx;
       I=find(FP.data(:,1) < FP.xLim(1));
       FP.data(I,:)=[];
       set(FP.axes,'xLim',FP.xLim);
   end
   % new values of yMin и yMax
   if y < FP.yLim(1) | FP.yLim(2) < y
       y= [y FP.yLim];
       FP.yLim= [min(y) max(y)];
       set(FP.axes,'yLim',FP.yLim);
   end
   % coordinates writing
   set(FP.line,'xData',FP.data(:,1),...
   'yData',FP.data(:,2));
