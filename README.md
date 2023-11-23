A few assumptions and technical decisions:
I started with the product service
I went with a bit more of an integration approach to test vs unit test as the structure supports it  integration  very well, however, I mostly prefer to mock the repository layer for unit test FYI.
Started running out of time: added api endpoints GetProductForView and GetProductForEdit without TTD
The orders table makes no sense, normally a order would contain a list of [order lines] which have a FK to products and a column quality ect (I did not implement this tho),
Run out of time so Order and customers I rushed with no TDD