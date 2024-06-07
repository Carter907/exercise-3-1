```
BEGIN
	CLASS Program
		Main METHOD
		      STR userIn = PROMPT USER ("enter message")
		  
		      IF (CHAR ARRAY OF userIn).Length > 140 THEN
		        PRINT
		        - "Rejected"
		      ELSE
		        PRINT
		        - "Posted"
		END Main
	END Program
END
```
