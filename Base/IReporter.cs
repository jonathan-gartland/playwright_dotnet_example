using System;
namespace PlaywrightTests.Base;

public interface IReporter
{
  void PrintAnnotation(Annotation annotation);
}