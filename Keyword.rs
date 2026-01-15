/* ============================================
   COMPLETE LIST OF RUST KEYWORDS
   ============================================

   Current Keywords (Rust 2021):
   
   as          - type casting, renaming imports
   async       - asynchronous functions and blocks
   await       - await completion of async computation
   break       - exit loop early
   const       - define constants or constant functions
   continue    - continue to next loop iteration
   crate       - crate root or external crate
   dyn         - dynamic dispatch for trait objects
   else        - fallback for if/if let
   enum        - define enumeration
   extern      - external function interface
   false       - boolean false literal
   fn          - define function or function pointer type
   for         - loop over items from iterator
   if          - conditional branch
   impl        - implement inherent or trait functionality
   in          - part of for loop syntax
   let         - bind variable
   loop        - unconditional loop
   match       - pattern matching
   mod         - define module
   move        - make closure take ownership of captured values
   mut         - denote mutability in references or bindings
   pub         - denote public visibility
   ref         - bind by reference
   return      - return from function
   Self        - type alias for implementor type
   self        - method subject or current module
   static      - static variable or lifetime
   struct      - define structure
   super       - parent module
   trait       - define trait
   true        - boolean true literal
   type        - define type alias or associated type
   union       - define union (unsafe)
   unsafe      - denote unsafe code, functions, traits, or implementations
   use         - import symbols into scope
   where       - denote clause constraining generic types
   while       - loop conditionally based on expression result

   Reserved Keywords (not yet in use):
   abstract    become       box         do          final       
   macro       override     priv        try         typeof      
   unsized     virtual      yield

   Raw Identifiers (r#keyword):
   Can use reserved keywords as identifiers by prefixing with r#
   Example: let r#match = 5;

   Special Identifiers (not keywords but special):
   _           - placeholder in patterns, ignores values
   dyn         - prefix for trait objects
   macro_rules - define macros

   ============================================
   Notes:
   - 'async' and 'await' stabilized in Rust 1.39
   - 'dyn' stabilized for trait objects in Rust 1.27
   - Raw identifiers (r#) stabilized in Rust 1.30
   - 'union' stabilized in Rust 1.19
   ============================================ */
