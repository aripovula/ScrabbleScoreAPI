# API endpoints are:

# 1. Classic CRUD or GET/POST/PUT/DELETE :

https://localhost:5101/api/ScrabbleScores        - get all, post, put, delete ScrabbleScores

https://localhost:5101/api/ScrabbleScores/{X}      - get Xth ScrabbleScore saved

post body option:

{
  "ScrabbleScore": 12,
  "Word": "ABC"
}


# 2. Classic ScrabbleScore:

https://localhost:5101/api/ScrabbleScores/getScore?word={AnyWord}      - get ScrabbleScore for word using exercism.io scoring value set.



# 3. ScrabbleScore with custom scoring value sets:

https://localhost:5101/api/ScoringValueSets        - get all, post, put, delete ScoringValueSets

Post body options:

Option 1:

{
	"ScoringValuesSet": "4:aelt,5:Dioug,1:bNrsCmp,8:fHvwY,2:k,3:Jx,10:qz"
}

Option 2:

{
	"ScoringValuesSet": "2:lRsct,4:diOug,3:bNp,5:fhMvwy,1:aEk,8:jx,10:qz"
}

https://localhost:5101/api/ScrabbleScores/getScore?word={AnyWord}&setId={1}   - get ScrabbleScore for word
