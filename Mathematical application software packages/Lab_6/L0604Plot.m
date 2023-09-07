%M-file 'anim.m' for Free Pendulum animation:
function [sys,x0]=L0604Plot(t,x,u,flag,par_ts);
  global ClockAnim
  global handle
  global yhour
  global xhour
  global xmin
  global ymin 
  global Lminh
  global Lhoursh
  % length of clock
  % update model: sys = mdlUpdate(t,x,u,par_ts)
  if flag==2,      
      %if get(0,'Children')== 1, % test, if plot exists
          set(0,'currentfigure',ClockAnim);
          % delete previous image (mode 'xor')
          plot(xhour,yhour,'w','linewidth',4);
          
          tc = 0:0.01:2*pi;
          xc=10*cos(tc);
          yc=10*sin(tc);
          plot(xc,yc,'b','linewidth',4);                          
          axis([-10-5 10+5 -10-5 10+5]); %axis properties
          % текущие координаты минутной стрелки и часовой стрелок
          xminh = Lminh * cos(pi/2 - pi * u / 1800);
          yminh = Lminh * sin(pi/2 - pi * u / 1800);
          xhourh = Lhoursh * cos(pi/2 - pi * u / 21600);
          yhourh = Lhoursh * sin(pi/2 - pi * u / 21600);
          x0 = 0; y0 = 0; % Координаты центра          
          % Current coordinates of Pendulum
          % [u(2)*sin(u(1)),-u(2)*cos(u(1))]
          %xH = L *sin(u(1));
          %yH = -L *cos(u(1));
          %xHm = Lm *sin(u(1)); % x curr of mass center
          %yHm = -Lm *cos(u(1)); % y curr of mass center
          
          % Рисование текущего положения стрелок
          %x=[xH x0];
          %y=[yH y0];
          xmin=[xminh x0];
          ymin=[yminh y0];
          xhour=[xhourh x0];
          yhour=[yhourh y0];
          plot(xhour,yhour,'r','linewidth',4);
          set(handle,'XData',xmin,'YData',ymin);          
          plot(x0,y0,'.','MarkerSize',30,...
          'EraseMode','none'); % plot center
          %plot(xHm,yHm,'.','MarkerSize',30,...
          %'EraseMode','xor'); % plot mass center
          %plot(xw, yw); 
          drawnow; % update plot
      %end
      sys=[];
  elseif flag == 4 % Return next sample hit
      % sys = mdlGetTimeOfNextVarHit(t,x,u,par_ts)
      sys = t + par_ts; % the constant sample interval
  elseif flag==0, 
      % Initialize the figure for use with this simulation
      [ClockAnim, par2] = animinit('Clock Animation');      
      axis([-15 15 -15 15]); % axis properties
      Lminh = 8;
      Lhoursh = 4;
      hold on      
      x0=0; y0=0; % Center coordinates      
      tc = 0:0.01:2*pi;
      xc=10*cos(tc);
      yc=10*sin(tc);
      plot(xc,yc,'b','linewidth',4);
      xm=x0;
      ym=y0 + Lminh;
      xh=x0;
      yh=y0 + Lhoursh;
      xmin=[xm xm];
      ymin=[ym y0];
      xhour=[xh x0];
      yhour=[yh y0];
      handle=plot(xmin,ymin,'g','lineWidth', 2);
      plot(xhour,yhour,'r','linewidth',4);
      %xHm=x0; yHm=y0-Lm; % Coordinates of mass center
      % Draw the current position of Pendulum
      %x=[xH x0]; y=[yH y0];
      % plot the Pendulum and init setting
      %handle=plot(x,y,'EraseMode','xor','LineWidth',5);
      % plot center point with size 30
      plot(x0,y0,'.','MarkerSize',30,...
      'EraseMode','none');
      % plot mass point with size 30
      %plot(xHm,yHm,'.','MarkerSize',30,...
      %    'EraseMode','xor');
      % Set the relative scaling of
      % the individual axis data values
      set(gca,'DataAspectRatio',[1 1 1]);
      sys=[0 0 0 1 0 0]; % 1 - number of inputs
      x0 = []; % No continuous states
  end;