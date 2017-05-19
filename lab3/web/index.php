<?php get_header() ?>
	<div class="content">
		<div class="container">

			<?php if (have_posts() ) : while (have_posts() ) : the_post() ?>
				<div class="post">
					<p class="post_title"><a href="<?php the_permalink() ?>"><?php the_title() ?></a></p>
					<div class="post_img" width="100px";>
						<?php the_post_thumbnail('full','post_img') ?>
					</div>
					<div class="post_description" width="100px";>
						<?php the_excerpt() ?>
					</div>
				</div>
			<?php endwhile ?>

			<?php else: ?>

			<?php endif ?>
			
		</div>
		<?php get_sidebar() ?>
	</div>
<?php get_footer() ?>