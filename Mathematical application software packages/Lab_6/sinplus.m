function [sys,x0,str,ts] = sinplus(t,x,u,flag,k)
%
  switch flag,
      case 0
          [sys,x0,str,ts]=mdlInitializeSizes;
      case 3
          sys=mdlOutputs(t,x,u,k);
      case { 1, 2, 4, 9 }
          sys=[];
      otherwise
          error(['Unhandled flag = ',num2str(flag)]);
  end
  
function [sys,x0,str,ts] = mdlInitializeSizes()
%
  sizes = simsizes;
  sizes.NumContStates = 0;
  sizes.NumDiscStates = 0;
  sizes.NumOutputs = -1;
  sizes.NumInputs = -1;
  sizes.DirFeedthrough = 1;
  sizes.NumSampleTimes = 1;
  sys = simsizes(sizes);
  str = [];
  x0 = [];
  ts = [-1 0];
  
function sys = mdlOutputs(t,x,u,k)
%
  if u<0
      sys=0;
  else
      sys=k*u;
  end;