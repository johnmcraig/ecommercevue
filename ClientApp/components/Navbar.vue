<template>
    <div id="menu">
		<a :to="{ name: 'Home' }" class="menuitem">Home</a>
		<a :to="{ name: 'Home' }" class="menuitem">About</a>
		<a :to="{ name: 'Users' }" class="menuitem">User List</a>
		<a href="#contact_content" class="menuitem">Contact</a>
	</div>
</template>

<script>
export default {
    name: 'Navbar'        
}
</script>

<style scoped>
#menu{
	text-align: center;
	color: black;
}
.menuitem{
	padding: 10px;
	cursor: pointer;
	text-decoration: none;
}
.menuitem:hover{
	background-color: black;
	color: white !important;
}
</style>
