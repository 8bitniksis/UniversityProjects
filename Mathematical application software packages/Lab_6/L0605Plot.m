%M-file 'anim.m' for Free Pendulum animation:
function [sys,x0]=L0605Plot(t,x,u,flag,par_ts);
  global PendAnim
  global handle
  global L Lm % length of Pendulum
  global xHm yHm % coordinates of mass center
  % update model: sys = mdlUpdate(t,x,u,par_ts)
  if flag==2,      
      %if get(0,'Children')== 1, % test, if plot exists
          set(0,'currentfigure',PendAnim);
          % delete previous image (mode 'xor')
          plot(xHm,yHm,'.','MarkerSize',30,...
          'EraseMode','xor');
          Lm=u(2); % pendulum length
          L=Lm-1; % pendulum length
          axis([-Lm-5 Lm+5 -Lm-5 Lm+5]); %axis properties
          % Current coordinates of Pendulum
          % [u(2)*sin(u(1)),-u(2)*cos(u(1))]
          xH = L *sin(u(1));
          yH = -L *cos(u(1));
          xHm = Lm *sin(u(1)); % x curr of mass center
          yHm = -Lm *cos(u(1)); % y curr of mass center
          x0=0; y0=0; % Center coordinates
          % Draw the current position of Pendulum
          x=[xH x0];
          y=[yH y0];
          set(handle,'XData',x,'YData',y);
          plot(x0,y0,'.','MarkerSize',30,...
          'EraseMode','none'); % plot center
          plot(xHm,yHm,'.','MarkerSize',30,...
          'EraseMode','xor'); % plot mass center
          drawnow; % update plot
      %end
      sys=[];
  elseif flag == 4 % Return next sample hit
      % sys = mdlGetTimeOfNextVarHit(t,x,u,par_ts)
      sys = t + par_ts; % the constant sample interval
  elseif flag==0, %[sys,x0,str,ts]=mdlInitializeSizes;
      % Initialize the figure for use with this simulation
      [PendAnim, par2] = animinit('Pendulum Animation');
      %PendAnim = findobj('Type','figure',...
       %   'Name','Pendulum Animation');
      axis([-45 45 -45 45]); % axis properties
      hold on
      % Set up the geometry for the problem
      Lm=40; %u(2); % Pendulum length
      L=Lm-1; %u(2); % Pendulum length
      x0=0; y0=0; % Center coordinates
      xH=x0; yH=y0-L;
      xHm=x0; yHm=y0-Lm; % Coordinates of mass center
      % Draw the current position of Pendulum
      x=[xH x0]; y=[yH y0];
      % plot the Pendulum and init setting
      handle=plot(x,y,'EraseMode','xor','LineWidth',5);
      % plot center point with size 30
      plot(x0,y0,'.','MarkerSize',30,...
      'EraseMode','none');
      % plot mass point with size 30
      plot(xHm,yHm,'.','MarkerSize',30,...
          'EraseMode','xor');
      % Set the relative scaling of
      % the individual axis data values
      set(gca,'DataAspectRatio',[1 1 1]);
      sys=[0 0 0 2 0 0]; % 2 - number of inputs
      x0 = []; % No continuous states
  end;
