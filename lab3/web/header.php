<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" type="text/css" href="style.css">
	<title><?php bloginfo('name') ?></title>
	<?php wp_head() ?>
</head>
<body>
	<div class="header">
		<div class="top_logo">
			<img id="logo" src="<?php bloginfo('template_url')?>/img/logo.png">
		</div>
		<div class="top_link_div">
			<a class="top_link" href="<?php echo home_url() ?>">Home</a>
			<a class="top_link" href="#">Profile</a>
			<a class="top_link" href="#">About</a>
			<a class="top_link_right" href="#">Github</a>
			<a class="top_link_right" href="#">Profile</a>
			<a class="top_link_right" href="http://materialdesign.rf.gd/login/">Login</a>
		</div>
	</div>