# ============================================
# COMPLETE LIST OF RUBY KEYWORDS
# ============================================
=begin
Ruby Keywords List:

1. Module and Class Definition:
   - module      # Define a module
   - class       # Define a class
   - def         # Define a method
   - undef       # Undefine a method
   - alias       # Create method alias
   - defined?    # Check if expression is defined

2. Inheritance and Mixins:
   - <           # Inheritance
   - include     # Include module (instance methods)
   - extend      # Extend module (class methods)
   - prepend     # Prepend module (methods take precedence)

3. Control Flow:
   - if / elsif / else
   - unless
   - case / when
   - while
   - until
   - for / in
   - loop
   - do
   - begin / end

4. Loop Control:
   - break       # Exit loop
   - next        # Skip to next iteration
   - redo        # Restart current iteration
   - retry       # Retry entire loop (in rescue)

5. Exception Handling:
   - raise       # Raise exception
   - rescue      # Handle exception
   - ensure      # Always execute (cleanup)
   - else        # Execute if no exception (in begin/rescue)

6. Blocks and Procs:
   - yield       # Yield to block
   - super       # Call parent method
   - ->          # Lambda literal
   - &           # Block to proc/proc to block

7. Variable Scope:
   - @           # Instance variable
   - @@          # Class variable
   - $           # Global variable
   - self        # Current object

8. Boolean and Nil:
   - true
   - false
   - nil

9. Logical Operators (keyword versions):
   - and         # Low precedence &&
   - or          # Low precedence ||
   - not         # Low precedence !

10. Special Keywords:
    - BEGIN      # Code to run at program start
    - END        # Code to run at program exit
    - __FILE__   # Current file name
    - __LINE__   # Current line number
    - __ENCODING__ # Script encoding

11. Pattern Matching (Ruby 2.7+):
    - in         # Pattern matching operator
    - =>         # Rightward assignment (Ruby 3.0+)

12. Other:
    - return     # Return from method
    - then       # Alternative to {} in control flow
    - =begin/=end # Multi-line comment

Reserved Words (not currently used):
- __id__
- __send__
- abort
- caller
- catch
- eval
- exec
- exit
- fail
- fork
- format
- getc
- gets
- gsub
- iterator?
- lambda
- load
- local_variables
- open
- p
- print
- printf
- proc
- putc
- puts
- readline
- readlines
- require
- select
- sleep
- split
- sprintf
- srand
- syscall
- system
- test
- throw
- trace_var
- trap
- untrace_var
- warn

Note: Ruby 3.x introduced:
- => for pattern matching
- Endless methods (def method() = expression)
- Pattern matching improvements
=end
